using MathGame2;
using static System.Formats.Asn1.AsnWriter;

var random = new Random();
var menu = new Menu();

var games = new List<string>();

string name = Helpers.GetName();

menu.ShowMenu(name);


