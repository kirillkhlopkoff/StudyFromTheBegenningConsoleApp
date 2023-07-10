// многомерный массив - можно представить как лобавление новых измерений, то есть 2-мерный, 3-мерный, 4-мерный и тд
// главное здесь не забываать, что память для массивов ограничена 2ГБ, а так же максимальным значение типа данных массиваа.
// указывается через запятые в квадратных скобках [,]
int[,,] matrix3D = new int[2, 6, 4];
Console.WriteLine($"matrix3D.Rank = {matrix3D.Rank}");
Console.WriteLine($"matrix3D.Length = {matrix3D.Length}");
Console.WriteLine($"matrix3D.GetLength(0) = {matrix3D.GetLength(0)}");
Console.WriteLine($"matrix3D.GetLength(1) = {matrix3D.GetLength(1)}");
Console.WriteLine($"matrix3D.GetLength(2) = {matrix3D.GetLength(2)}");

Console.ReadLine();

// зубчатые массивы или массивы массивов - представляют собой массив состоящий из неравномерных массивов, каждый может иметь свою длину.
// указывается квадратными скобками после квадратных скобок [][].
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[2];
jaggedArray[0][0] = 1;
jaggedArray[0][1] = 4;

jaggedArray[1]= new int[3];
jaggedArray[1][0] = 5;
jaggedArray[1][1] = 6;
jaggedArray[1][2] = 1;

jaggedArray[2]= new int[5];
jaggedArray[2][0] = 2;
jaggedArray[2][1] = 6;
jaggedArray[2][2] = 1;
jaggedArray[2][3] = 4;
jaggedArray[2][4] = 3;

for (int i = 0; i < jaggedArray.Length; i++)
{
	for (int j = 0; j < jaggedArray[i].Length; j++)
	{
        Console.Write($"{jaggedArray[i][j]} ");
    }
    Console.WriteLine();
}
Console.ReadLine();


// дальше был урок про foreach, там его использовали для перебора массива массивов, как элемент из коллекции
// на практике же я его использовал часто в представлениях, что бы вывести, например, элементы из базы данных на страницу.