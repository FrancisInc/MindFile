using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MindFileClassLibrary
{
    class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> Hobbies { get; set; }
        public string FavouriteSong { get; set; }
    }
}