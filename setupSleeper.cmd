mkdir c:\programs\sleeper
copy Sleeper.WinForm.exe c:\programs\sleeper

schtasks /create /tn Sleeper.kal /tr c:\programs\sleeper\Sleeper.WinForm.exe /sc DAILY /st 05:00:00 /ru kal /it /f

schtasks /create /tn Sleeper.jingyuan /tr c:\programs\sleeper\Sleeper.WinForm.exe /sc DAILY /st 05:00:00 /ru jingyuan /it /f

pause