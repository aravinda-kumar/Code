@echo off
echo 正在清理VC垃圾文件，请稍等......
del /f /s /q .\*.pch
del /f /s /q .\*.sbr
del /f /s /q .\*.bsc
del /f /s /q .\*.idb
del /f /s /q .\*.res
del /f /s /q .\*.pdb
del /f /s /q .\*.obj
del /f /s /q .\*.ilk
del /f /s /q .\*.ncb
del /f /s /q .\*.dep
del /f /s /q .\*.opt
del /f /s /q .\*.plg