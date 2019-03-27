using UnityEngine;

public class Greetings : IGreetings
{
    private string _message = "Gello";
    public string Message => _message;
}
