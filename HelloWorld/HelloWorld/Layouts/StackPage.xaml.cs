﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Layouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackPage : ContentPage
	{
		public StackPage ()
		{
			InitializeComponent ();
		}
	}
}