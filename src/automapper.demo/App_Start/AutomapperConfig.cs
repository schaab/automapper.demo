using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using automapper.demo.Automapper;

namespace automapper.demo
{
    public class AutomapperConfig
    {
        private static bool _isRegistered = false;

        public static void RegisterMappings()
        {
            if (!_isRegistered)
            {
                Mapper.Initialize(cfg => {
                    cfg.AddProfile<MappingProfile>();
                });
            }
        }
    }
}