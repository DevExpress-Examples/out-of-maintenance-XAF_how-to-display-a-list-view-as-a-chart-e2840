;#DropDB ChartExampleEasyTest

#Application ChartExampleWin
#Application ChartExampleWeb

*Action Navigation(User)

*ProcessRecord
 Full Name = ''

#IfDef ChartExampleWeb
*Action Edit
#EndIf
 
*FillForm
 Full Name = Test User
 
*Action Cancel

#IfDef ChartExampleWin
*HandleDialog
 Respond = Yes
#EndIf

*CheckFieldValues
 Full Name = ''
