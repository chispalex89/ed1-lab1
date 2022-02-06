﻿using Laboratorio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public List<PokemonModel> pokemonList = new List<PokemonModel>
        {
            new PokemonModel
            {
                Id = 7,
                Name = "Squirtle",
                HP = 44,
                Attack = 48,
                Defense = 65,
                SpecialAttack = 50,
                SpecialDefense = 64,
                Speed = 43
            }
        };
    }
    public class DataDBZ
    {
        private static DataDBZ instanceDBZ = null;
        public static DataDBZ InstanceDBZ
        {
            get
            {
                if(instanceDBZ == null)
                {
                    instanceDBZ = new DataDBZ();
                }
                return instanceDBZ;
            }
        }
        public List<DBZModel> dbzList = new List<DBZModel>
        {
            new DBZModel
            {
                Id = 1,
                Name = "Goku",
                NPower = 1000,
                SpecialAttack = "Kame Kame Ha"
                
            }
        };
    }
}
