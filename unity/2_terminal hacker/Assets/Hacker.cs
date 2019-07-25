using UnityEngine;

public class Hacker : MonoBehaviour {
    // Use this for initialization
    string menuhint = "you can go for menu at any time";

    string esc = "press exit to exit";
    int level;
    string password, pass;
    string[] passwords = { "aman", "adarsh", "om", "dikshit" };
    enum Screen { main, password, win }
    Screen currentscreen;
    void Start()
    {
        print("hello " + "world ");
        var greet = "hello dikshit";
        Terminal.WriteLine(greet);
        showmain();
    }
    void showmain()
    {
        currentscreen = Screen.main;
        Terminal.ClearScreen();
        Terminal.WriteLine("Make your choice : ");

        Terminal.WriteLine(esc);
    }
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            showmain();
        }
        else if (input == "exit")
        {
            Application.Quit();
        }
        else if (currentscreen == Screen.main)
        {
            letsplay(input);
        }
        else if (currentscreen == Screen.password)
        {
            checkpassword(input);
        }
    }
    void whatelse()
    {
        Terminal.WriteLine("try again");
    }
    void letsplay(string input)
    {
        bool validnumber = (input == "1" || input == "2");
        if(validnumber)
        {
            level = int.Parse(input);
            startgame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("please select a level");
        }
        else
        {
            Terminal.WriteLine("please select a valid level");
            Terminal.WriteLine(menuhint);
        }
    }

    void startgame()
    {
        print(passwords.Length);
        currentscreen = Screen.password;
        Terminal.ClearScreen();
        Terminal.WriteLine("You choose level " + level);
        askforpassword();
        Terminal.WriteLine("Tell the password hint :" + password.Anagram());
        Terminal.WriteLine(menuhint);

    }

    void askforpassword()
    {
        switch (level)
        {
            case 1:
                {
                    int index = Random.Range(0, passwords.Length);
                    password = passwords[index];
                    break;
                }
            case 2:
                {
                    int index = Random.Range(0, passwords.Length);
                    password = passwords[index];
                    break;
                }
            default:
                {
                    Debug.Log("invalid");
                    break;
                }

        }
    }

    void checkpassword(string input)
    {
        if(input==password)
        {
            winscreen();
        }
        else
        {
            startgame();
        }
    }

    private void winscreen()
    {
        Terminal.ClearScreen();
        switch (level)
        {
            case 1:
                reward();
                break;
            case 2:
                rewards();
                break;
        }

    }

    void rewards()
    {
        Terminal.WriteLine("you won");
        Terminal.WriteLine("you  got icecream");
        Terminal.WriteLine(@"


                   sex  
                  sunny          
                 ommbhai
                amanlovek
               amandikshit
                \-------/   
                 \-----/
                  \---/
                   \-/                                                
                                ");

        Terminal.WriteLine(esc);
    }

    void reward()
    {
        Terminal.WriteLine("you won");
        Terminal.WriteLine("you got nothing");
        Terminal.WriteLine(@"
                                                           
                                                              
                  /      ,,m,f  
                 / sfsdfn/ jfh
                /fdffhbn/  fd                                    
               /fdsffdf/   fd
               \fdsfdd/    d                                           
                \dffd/
                 \fd/
                  \/               
                                                                            
                             ");

        Terminal.WriteLine(esc);
    }

    // Update is called once per frame
    void Update ()
    {
        int a = Random.Range(0, passwords.Length);
        print(a);
	}
}

