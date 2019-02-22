using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.AutoMap
{
    public static class AutoMapperConfiguration
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.AddProfile(new AutoMapperProfile());
            });

            return configuration;
        }        
    }
}
