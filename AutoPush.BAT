@echo off
setlocal enabledelayedexpansion

for /f "tokens=*" %%i in ('git branch -a') do (
    if /i "%%i"=="* main" set MAIN_BRANCH=main
    if /i "%%i"=="* master" set MAIN_BRANCH=master
)

if not defined MAIN_BRANCH (
    echo Could not determine the main branch. Is it "main" or "master"?
    pause
    exit /b 1
)

echo Main branch is: %MAIN_BRANCH%

git checkout %MAIN_BRANCH%

set /p BRANCH_NAME="Enter the name of the new branch: "
git checkout -b %BRANCH_NAME%

git add -A

set /p COMMIT_MESSAGE="Enter commit message: "
git commit -m "%COMMIT_MESSAGE%"

git checkout %MAIN_BRANCH%
git merge --no-ff %BRANCH_NAME%

git push origin %MAIN_BRANCH%
git push origin %BRANCH_NAME%

echo All tasks completed successfully!
pause