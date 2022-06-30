namespace ConsoleApp.OOP;
record struct Tyre(float AirPresure);
record struct Wheel(int Id, int Size, Tyre Tyre, object Rim);
record struct Door(int Id, bool HasChildSafety, bool HasPowerWindows);
