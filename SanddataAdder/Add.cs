using Logger;

namespace SanddataAdder;

public class Add
{
    int AddInt(int a, int b)
    {
        var logger = new SanddataLogger();
        logger.Logger("Addint");
        return a + b;
    }
}