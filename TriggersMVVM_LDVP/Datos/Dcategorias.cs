using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_LDVP.Modelo;

namespace TriggersMVVM_LDVP.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {

                    descripcion="Lambo Diablo",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/Cz1cYtK/IMG-6367.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"
                },
                new Mcategorias()
                {
                    descripcion="Impala",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/sqD40Kg/IMG-6369.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"

                },
                new Mcategorias()
                {
                    descripcion="Lancer",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/wK38ZjV/IMG-6371.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"
                },
                new Mcategorias()
                {
                    descripcion="Charger",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/7YX5661/IMG-6373.png",
                    backgroundColor="#000000",
                    textColor="#ffffff"
                }
            };
        }
    }
}
