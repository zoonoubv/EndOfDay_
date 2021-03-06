using System;
using System.IO;
using System.Text.RegularExpressions;
using Gtk;

public partial class MainWindow: Gtk.Window{

	public string clientNameString;
	public string projectNameString;
	public string urlUsedString;
	public string buildVersionString;
	public string[] primListArray;
	public string[] top5ListArray;
	public static bool bSmokes;
	public static bool bInitEnabled;
	public string[] initArray = new string[12];
	public bool[] initEnabledArray = new bool[12];
	public static string sAllinitials;

	public int addCounter;

	public int programControl;

	//<param> Application start </param>
	public MainWindow () : base (Gtk.WindowType.Toplevel){}

	public void main(){
		ReportSectionOne();
	}

	//<param> Application closes </param>
	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
		Application.Quit ();
		a.RetVal = true;
	}

	#region MainEvents

	protected void OnM5H2MainCheck2Toggled (object sender, EventArgs e){
		switch (programControl){
		case 1:
			Level1Check2Toggled();
			break;
		case 2:
			Console.WriteLine("asd");
			break;
		default:
			break;
		}
	}//

	protected void OnM5H2MainCheck1Toggled (object sender, EventArgs e){
		switch (programControl){
		case 1:
			Level1Check1Toggled();
			break;
		case 2:
			Console.WriteLine("asd");
			break;
		default:
			break;
		}
	}//

	protected void OnMainButtonControls1Clicked (object sender, EventArgs e){
		switch (programControl){
		case 1:
			Level1ButtonControls1Clicked();
			break;
		case 2:
			Level2Button();
			//Console.WriteLine("asd");
			break;
		case 3:
			Level3Button();
			break;
		case 4:
			level4Button();
			break;
		case 5:
			level5Button();
			break;
		case 6:
			Level6Button();
			break;
		default:
			break;
		}
	}

	protected void OnButton1Clicked (object sender, EventArgs e){
		switch (programControl){
		case 1:
			PrimAdd();
			break;
		case 2:
			Console.WriteLine("asd");
			break;
		default:
			break;
		}
	}

	protected void OnRadiobutton10Toggled (object sender, EventArgs e){
		switch (programControl){
		case 1:
			Level1Toggled10();
			break;
		case 2:
			break;
		case 3:
			break;
		default:
			break;
		}
	}

	protected void OnRadiobutton8Toggled (object sender, EventArgs e){
		switch (programControl){
		case 1:
			Level1Toggled8();
			break;
		case 2:
			Console.WriteLine("asd");
			break;
		default:
			break;
		}
	}

	protected void OnRadiobutton6Toggled (object sender, EventArgs e){
		switch (programControl){
		case 1:
			Level1Toggled6();
			break;
		case 2:

			break;
		default:
			break;
		}
	}

	//ATM Blank   
	protected void OnRadiobutton4Toggled (object sender, EventArgs e){
	}

	protected void OnRadiobutton2Toggled (object sender, EventArgs e){
		switch (programControl){
		case 1:
			break;
		case 2:
			break;
		case 3:
			Level3Check2Toggled();
			break;
		default:
			break;
		}
	}

	//ATM Blank
	protected void OnMainButtonControls2Clicked(object sender, EventArgs e){
		switch (programControl){
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			//level5ButtonControls2Clicked();
			break;
		default:
			break;
		}
	}

	protected void OnM3H2MainCheck1Toggled(object sender, EventArgs e){
		switch (programControl){
		case 1:
			break;
		case 2:
			Level2Check1Toggled();
			break;
		case 3:
			break;
		default:
			break;
		}
	}

	protected void OnM3H2MainCheck2Toggled(object sender, EventArgs e){
		switch (programControl){
		case 1:
			break;
		case 2:
			Level2Check2Toggled();
			break;
		case 3:
			break;
		default:
			break;
		}
	}

	protected void OnM3H2MainCheck3Toggled(object sender, EventArgs e){
		switch (programControl){
		case 1:
			break;
		case 2:
			Level2Check3Toggled();
			break;
		case 3:
			break;
		default:
			break;
		}
	}

	protected void OnMainButtonControls3Clicked (object sender, EventArgs e){
		switch (programControl){
		case 1:
			break;
		case 2:
			ReportSectionOne();
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
		default:
			break;
		}
	}


	protected void OnInCheck1Toggled (object sender, EventArgs e){
		if(InCheck1.Active){
			initEnabledArray[0] = true;
		}
		else{
			initEnabledArray[0] = false;
		}
	}

	protected void OnInCheck2Toggled (object sender, EventArgs e){
		if(InCheck2.Active){
			initEnabledArray[1] = true;
		}
		else{
			initEnabledArray[1] = false;
		}
	}

	protected void OnInCheck3Toggled (object sender, EventArgs e){
		if(InCheck3.Active){
			initEnabledArray[2] = true;
		}
		else{
			initEnabledArray[2] = false;
		}
	}

	protected void OnInCheck4Toggled (object sender, EventArgs e){
		if(InCheck4.Active){
			initEnabledArray[3] = true;
		}
		else{
			initEnabledArray[3] = false;
		}
	}

	protected void OnInCheck5Toggled (object sender, EventArgs e){
		if(InCheck5.Active){
			initEnabledArray[4] = true;
		}
		else{
			initEnabledArray[4] = false;
		}
	}

	protected void OnInCheck6Toggled (object sender, EventArgs e){
		if(InCheck6.Active){
			initEnabledArray[5] = true;
		}
		else{
			initEnabledArray[5] = false;
		}
	}

	protected void OnInCheck7Toggled (object sender, EventArgs e){
		if(InCheck7.Active){
			initEnabledArray[6] = true;
		}
		else{
			initEnabledArray[6] = false;
		}
	}

	protected void OnInCheck8Toggled (object sender, EventArgs e){
		if(InCheck8.Active){
			initEnabledArray[7] = true;
		}
		else{
			initEnabledArray[7] = false;
		}
	}

	protected void OnInCheck9Toggled (object sender, EventArgs e){
		if(InCheck9.Active){
			initEnabledArray[8] = true;
		}
		else{
			initEnabledArray[8] = false;
		}
	}

	protected void OnInCheck10Toggled (object sender, EventArgs e){
		if(InCheck10.Active){
			initEnabledArray[9] = true;
		}
		else{
			initEnabledArray[9] = false;
		}
	}
	

	protected void OnInCheck11Toggled (object sender, EventArgs e){
		if(InCheck11.Active){
			initEnabledArray[10] = true;
		}
		else{
			initEnabledArray[10] = false;
		}
	}

	protected void OnInCheck12Toggled (object sender, EventArgs e){
		if(InCheck12.Active){
			initEnabledArray[11] = true;
		}
		else{
			initEnabledArray[11] = false;
		}
	}


	protected void OnInitradiobutton1Toggled (object sender, EventArgs e){
			switch (programControl){
			case 1:
				break;
			case 2:
				InCheck15Toggled();
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
			default:
				break;
			}
	}
	#endregion
}



