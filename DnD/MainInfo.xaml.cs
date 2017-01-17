using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DnD
{
	public partial class MainInfo : ContentPage
	{
		User user;
		int v;

		public MainInfo()
		{
			InitializeComponent();
		}

		public MainInfo(User user, int v)
		{
			this.user = user;
			this.v = v;
		}
	}
}
