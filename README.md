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
    Note*: The xUnit Test Runners may be required
        - install via Nuget Package manager


So there is a pretty big issue with testing both the TeamsController and MatchController as they both inherit the MonoBehaviour class. We won't be able to test them directly as 
    they can only be constructed via the and not via any code we write so at the moment they are literally untestable without any
    serious hacks (I'm not even certain how to hack around this either). And Since we can't refarctor the source code directly we can 
    just pretend it's easy to work with instead.

The following link touchs on why we won't be able to test anything inheriting MonoBehaviour directly.
http://blogs.unity3d.com/2014/06/03/unit-testing-part-2-unit-testing-monobehaviours/
            
        
