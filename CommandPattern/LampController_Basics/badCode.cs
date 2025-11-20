// namespace CommandPattern;
// public class LampController
// {
//     private int brightness = 50;
//     private bool isOn = false;

//     public string Execute(string command)
//     {
//         if (command == "on")
//         {
//             isOn = true;
//             return "Lamp turned ON";
//         }
//         else if (command == "off")
//         {
//             isOn = false;
//             return "Lamp turned OFF";
//         }
//         else if (command == "inc")
//         {
//             brightness += 10;
//             return $"Brightness increased to {brightness}";
//         }
//         else if (command == "dec")
//         {
//             brightness -= 10;
//             return $"Brightness decreased to {brightness}";
//         }
//         else
//         {
//             return "Invalid command!";
//         }
//     }
// }
