using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}

//koga sakame vo nekoe View da vratime povekje atributi mora da kreirame nashe ViewModel koe ke gi sodrzhi site elementi 
// koi sto sakame da gi prikazheme. Vo solution kreirame FOLDER po ime "ViewModels" i vo nego gi chuvame nashite kreirani ViewModel.
//Ova e primer za viewModel vo koe ima dva objekti od klasite odnosno MODELS Movie i Lista od Customer.