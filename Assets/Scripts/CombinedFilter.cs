
public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return Modulo3Filter.moduloInput(ModuloFirst.ModFirstVals(xs));
        //...(0,1,1,1,1,0)
    }
}

