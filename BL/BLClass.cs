using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Models;
using DAL;
using Newtonsoft.Json;

namespace BL
{
    public class BLClass
    {


        public List<ClosestAgent> GetCloestAgent()
        {
            SRVReference.SRVClient client = new SRVReference.SRVClient("BasicHttpBinding_ISRV");
            // source location
            // HaNapah Street, Karmiel
            // Latitude = 32.92146 Longitude = 35.31982
            var sourceLat = 32.92146;
            var sourceLng = 35.31982;


            using (DispatcherEntities en = new DispatcherEntities())
            {
                var q = en.tech_agents
                            .ToList()
                            .Select(s => new ClosestAgent
                            {
                                Name = s.name,
                                Distance = client.GetDis(sourceLng, sourceLat, s.longitude, s.latitude),
                                ToLat = s.latitude,
                                ToLng = s.longitude
                            })
                            .OrderBy(v => v.Distance)
                            .Take(5);

                var agentsList = q.ToList();
                return agentsList;
            }
        }

        public void JsonToFile(List<ClosestAgent> CA) {
            var features = new List<Feature>();

            foreach (var item in CA)
            {
                var f = new Feature
                {
                    type = "Feature",
                    geometry = new Geometry
                    {
                        type = "Point",
                        coordinates = new List<double> { item.ToLng, item.ToLat }
                    },
                    properties = new BL.Models.Properties
                    {
                        name = item.Name,
                        icon = "http://maps.google.com/mapfiles/ms/micons/mechanic.png"
                    }
                };

                features.Add(f);
            }

            var ro = new RootObject
            {
                type = "FeatureCollection",
                features = features
            };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"C:\Users\Eran\source\repos\astea\googlemapWebApp\google-maps-app\coordinates.json", JsonConvert.SerializeObject(ro));
        }
    }
}
