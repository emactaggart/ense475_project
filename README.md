# ense475_project

To get up and running in Visual Studios:
    - Install Unity: 
    - Install Visual Studio
    - Install Visual Studio 2013 Tools for Unity:
        - go into Tools -> Extensions and Updates:
            - Choose Online
            - search 'unity'
            - select and install 'Visual Studio 2013 Tools for Unity'
    - Start up unity:
        - go through Unity setup
        - after setup, select existing project:
            - go to directory where you unzipped 'capstoneproject.zip'
            - select the folder at 'PROJECT_ROOT/capstoneProject'
            - Unity should then attempt to import it, it will probably say something about converting files to 
                newer version (it may stop responding just wait for it, or cancel and try to open it again)
        - once the project is open in Unity:
            - go to Assets -> Import Package -> Custom Package
            - select /C:/Program Files (x86)/Microsoft Visual Studio Tools for Unity/2013/Visual Studio 2013 Tools.unitypackage
        - after Visual Studio 2013 Tools are imported:
            - there should now be a Visual Studio Tools menu
            - select Visual Studio Tools -> Open in Visual Studio
    - Now we must include the test project:
        - first ensure it is cloned from the git repository
        - in Visual Studio, with the capstoneProject still loaded, right click on 'UnityVS.capstoneproject' in the Solution Explorer
        - Add -> Existing Project
        - select the project from the git repository
    - Everything should be complete, the Nuget package manager may complain that you need to download some packages, feel free
        to do so.

To Run Tests:
    -Test -> Run -> All Tests


            
        
    
