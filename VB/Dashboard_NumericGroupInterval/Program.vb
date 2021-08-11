﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.Data.Filtering
Imports System.Globalization

Namespace Dashboard_NumericGroupInterval
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			BonusSkins.Register()
			SkinManager.EnableFormSkins()
			UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful")
			CriteriaOperator.RegisterCustomFunction(New GetNumericGroupIntervalFunction())
			Application.Run(New Form1())

		End Sub
	End Module
End Namespace
