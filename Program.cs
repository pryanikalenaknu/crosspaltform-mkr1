using CrossplatformMKR_1;

var input = FileUtil.Read(FileUtil.ReadPath);

var N = int.Parse(input[0]);
var splitedM = input[1].Split();

var M = Array.ConvertAll(splitedM, int.Parse);
var firstTask = new MKRTask(N, M);

var res = firstTask.Calculate();

Console.WriteLine($"Result = {res}");

FileUtil.Write(FileUtil.WritePath, res);