﻿using AuthenticationServices;
using MauiAppC_basic.Classes;
using Microsoft.VisualBasic;

namespace MauiAppC_basic;

public partial class MainPage : ContentPage
{
	Car audi;
	Car nissan;
	bool isFinish = false;
	public MainPage()
	{
		InitializeComponent();
		audi = new Car("A1", 220, 10);
		audi.UseFuelRate = 10;
		nissan = new Car("S1", 180, 3);
		nissan.UseFuelRate = 8;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if (!this.isFinish)
		{
			var screenWidth = Application.Current.MainPage.Width;
			this.AudiRun(screenWidth);
			this.NissanRun(screenWidth);
			this.myLabel.Text = audi.Showinfo() + "\n" + nissan.Showinfo();
			this.isFinish = true;
		}
		else
		{
			ImageCar1.TranslateTo(0, 0, 0, Easing.Linear);
			ImageCar2.TranslateTo(0, 0, 0, Easing.Linear);
			this.isFinish = false;
		}
		//audi.Run(10);
		//nissan.Run(5);
		//myLabel.Text = audi.Showinfo() +"\n" + nissan.Showinfo();
	}
	private void AudiRun(double distance)
	{
		var timeuse = audi.TimeUseForRun(distance);
		ImageCar1.TranslateTo(distance - 100, 0, timeuse * 100, Easing.Linear);
	}
	private void NissanRun(double distance)
	{
		var timeuse = nissan.TimeUseForRun(distance);
		ImageCar2.TranslateTo(distance - 100, 0, timeuse * 100, Easing.Linear);
	}
}



