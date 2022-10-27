/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 

AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
*/
void GetDistanceBetweenTwoPiont(int firstX, int secondX, int firstY, int secondY, int firstZ, int secondZ)
{
    double result = 0;

    int tempX = (secondX - firstX) * (secondX - firstX);
    int tempY = (secondY - firstY) * (secondY - firstY);
    int tempZ = (secondZ - firstZ) * (secondZ - firstZ);

    result = Math.Sqrt(tempX + tempY + tempZ);
    Console.WriteLine($"Расстояние между двумя точками {result}");
}
GetDistanceBetweenTwoPiont(3, 6, 8, 2, 1, -7);