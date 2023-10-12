namespace ResharperExamples;

public class MethodAndVariableExtracting
{
    /*
     * В этом классе содержатся примеры рефакторинга с использованием Resharper 
     * Ctrl + Alt + V - выделение переменной
     * Ctrl + Alt + M - выделение метода
     * F2 - переименование
     * Эти и многие другие действия можно увидеть нажав Alt + Enter, либо Ctrl + Shift + R
     *
     * В качестве примера возьмем метод CalculateConstantAccelerationVelocity вычисляющий скорость объекта по начальной
     * скорости, ускорению, начальному времени и конечному времени.
     * Почитать про формулу можно тут: https://en.wikipedia.org/wiki/Acceleration#Uniform_acceleration
     */

    /* Выдедение переменной Ctrl + Alt + V */

    public double CalculateConstantAccelerationVelocity(
        double startVelocity,
        double acceleration,
        DateTime startTime,
        DateTime endTime)
    {
        // Что не так с этой формулой? Достаточно ли она универсльна?
        // Попробуем вынести в отдельную переменную время, которе тело потратило на равноускоренное движение.
        // Для этого выделим endTime - startTime).TotalHours и нажмите Ctrl + Alt + V
        // После выделения переменной можно без лишних нажатий задать ей нужное имя, например time
        return startVelocity + acceleration * (endTime - startTime).TotalHours;
    }

    /* Выдедение метода Ctrl + Alt + M */

    public double CalculateConstantAccelerationVelocity1(
        double startVelocity,
        double acceleration,
        DateTime startTime,
        DateTime endTime)
    {
        // Так то лучше! сразу видно, как мы получаем время
        var time = (endTime - startTime).TotalHours;

        // Теперь для вычисления возвращаемого значения мы используем "классическую" формулу
        // Наши друзья тоже хотят пользоваться этой удобной формулой
        // Попробуем вынести ее в отдельный метод!
        // Выделим startVelocity + acceleration * time и нажмем Ctrl + Alt + M
        return startVelocity + acceleration * time;
    }

    public double CalculateConstantAccelerationVelocity2(
        double startVelocity,
        double acceleration,
        DateTime startTime,
        DateTime endTime)
    {
        var time = (endTime - startTime).TotalHours;

        // Отлично! метод вынесен, мы и можем переиспользовать его много раз!
        return StartVelocity(startVelocity, acceleration, time);
    }

    private static double StartVelocity(double startVelocity, double acceleration, double time)
    {
        return startVelocity + acceleration * time;
    }

    /* Переименование F2 */

    public double CalculateConstantAccelerationVelocity3(
        double startVelocity,
        double acceleration,
        DateTime startTime,
        DateTime endTime)
    {
        var time = (endTime - startTime).TotalHours;

        // Обрадовавшись новой фиче, наш друг использовал код для своих экспериментов
        // Но он нашел неточность в названии метода. "Какой же это StartVelocity()? Это перегрузка CalculateConstantAccelerationVelocity()!"
        // Давайте исправим название метода выделим StartVelocity либо в месте объявления, либо в месте использования и нажмем F2
        var someVelocities = new []
        {
            StartVelocity(startVelocity, acceleration - 3, time),
            StartVelocity(startVelocity, acceleration - 2, time),
            StartVelocity(startVelocity, acceleration - 1, time),
            StartVelocity(startVelocity, acceleration, time),
            StartVelocity(startVelocity, acceleration + 1, time),
            StartVelocity(startVelocity, acceleration + 2, time),
            StartVelocity(startVelocity, acceleration + 3, time)
        };

        return someVelocities.Max();
    }

    public double CalculateConstantAccelerationVelocity4(
        double startVelocity,
        double acceleration,
        DateTime startTime,
        DateTime endTime)
    {
        var time = (endTime - startTime).TotalHours;

        // Ура! Мы произвели рефакторинг всего в одном месте, а переименование применилось везде
        var someVelocities = new []
        {
            CalculateConstantAccelerationVelocity(startVelocity, acceleration - 3, time),
            CalculateConstantAccelerationVelocity(startVelocity, acceleration - 2, time),
            CalculateConstantAccelerationVelocity(startVelocity, acceleration - 1, time),
            CalculateConstantAccelerationVelocity(startVelocity, acceleration, time),
            CalculateConstantAccelerationVelocity(startVelocity, acceleration + 1, time),
            CalculateConstantAccelerationVelocity(startVelocity, acceleration + 2, time),
            CalculateConstantAccelerationVelocity(startVelocity, acceleration + 3, time)
        };

        return someVelocities.Max();
    }

    private static double CalculateConstantAccelerationVelocity(double startVelocity, double acceleration, double time)
    {
        return startVelocity + acceleration * time;
    }
}