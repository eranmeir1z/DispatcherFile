using BL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using XX;

namespace UI
{


    public static class GoogleHelpers
    {

        public static string CreateJson(List<ClosestAgent> CA)
        {
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

            var result = JsonConvert.SerializeObject(ro);
            return result;
        }


    }
}

//// TODO: ...
//namespace XX
//{
//    public class Geometry
//    {
//        public string type { get; set; }
//        public List<double> coordinates { get; set; }
//    }

//    public class Properties
//    {
//        public string name { get; set; }
//        public string icon { get; set; }
//    }

//    public class Feature
//    {
//        public string type { get; set; }
//        public Geometry geometry { get; set; }
//        public Properties properties { get; set; }
//    }

//    public class RootObject
//    {
//        public string type { get; set; }
//        public List<Feature> features { get; set; }
//    }
//}