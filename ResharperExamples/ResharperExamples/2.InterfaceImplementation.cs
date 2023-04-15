namespace ResharperExamples;

/*
 * Допустим, у нас есть интерфейс который мы хотим реализовать
 * Для этого мы можем воспользоваться Resharper
 * Чтобы реализовать в текущем классе нужный интерфейс,
 * выделите название класса, нажмите Alt + Enter -> "Implement missing members"
 */
public class InterfaceImplementation : IMyPerfectInterface
{
}

/*
 * Кроме того, по интерфейсу можно сгененрирвать наследующий его класс и потратьить еще меньше времени на написание кода!
 * Просто выделите название интерфейса, нажмите Alt + Enter -> "Create derived type"
 */

public interface IMyPerfectInterface
{
    int GetMyFavouriteNumber();

    double GetMyFavouriteDoubleNumber();

    double SummarizeMyNumbers(params int[] numbers);

    string StringifyMyNumbers(params int[] numbers);
}