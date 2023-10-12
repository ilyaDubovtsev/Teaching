namespace ResharperExamples;

public class CodeCompletion
{
    public void Example()
    {
        // Часто при вызове метода непонятно какие у него праметры:

        Math.Pow();

        /*
         * Можно навести каретку внутрь скобок и нажмите Ctrl + P, появится подсказка с названиями параметров
         * и возможными перегрузками
         */

        var myFavouriteNumber = 2;
        var myFavouritePower = 10;

        /*
         * Но это еще не все! При нажатии Ctrl + Space внутри скобок, Resharper предложит нам подходящие параметры,
         * в нашем случае это переменные myFavouriteNumber и myFavouritePower
         */

        Math.Pow();

        /*
         * Если же мы хотим поменять порядок передаваемых параметров, мы можем использовать Ctrl + Shift + Alt + ←/→ 
         */

        Math.Pow(myFavouritePower, myFavouriteNumber);

        /*
         * Для изменения порадка строчек, мотодов и т.д можно использовать Ctrl + Shift + Alt + ↑/↓
         */

        Math.Pow(myFavouriteNumber + 1, myFavouritePower);
        Math.Pow(myFavouriteNumber + 3, myFavouritePower);
        Math.Pow(myFavouriteNumber + 2, myFavouritePower);
        Math.Pow(myFavouriteNumber + 4, myFavouritePower);

    }
}