Imports DevExpress.XtraBars.Ribbon

Namespace Dashboard_NumericGroupInterval
	Partial Public Class Form1
		Inherits RibbonForm

		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.CreateRibbon()
			dashboardDesigner1.LoadDashboard("..\..\Data\NumericGroupIntervalFunctionWithMathValues.xml")
		End Sub
	End Class
End Namespace
