Option Strict Off
Option Explicit On
Module modMain
	Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags_ As Integer) As Integer

	Public intTotalSal, intTotalPD, intTotalAF As Short
	Public intCrewPD2, intCrewPD1, intCrewPD3 As Short
	Public intCrew2, intCrew1, intCrew3 As Short
	Public intAF2, intAF1, intAF3 As Short
	Public intCheck As Short
End Module