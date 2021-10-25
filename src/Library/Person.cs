﻿using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fecha)
        {
            this.Name = name;
            this.ID = id;
            this.Fecha = fecha;

        }

        private string name;

        private string id;

        private string fecha;




        public string Fecha
        {
            get
            {
                return this.fecha;
            }
            
            set
            {
                if (fecha.Length < 10)
                {
                    this.fecha = value;
                }
            }
        }

    

        



        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
