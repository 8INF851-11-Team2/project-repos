namespace LOCMI.Core;

public interface IMicrocontrollerAdapter
{
    public IMicrocontrollerAdapter BuildConnectors();

    public IMicrocontrollerAdapter BuildDimension();

    public IMicrocontrollerAdapter BuildDisk();

    public IMicrocontrollerAdapter BuildIdentification();

    public IMicrocontrollerAdapter BuildLanguage();

    public IMicrocontrollerAdapter BuildName();

    public IMicrocontrollerAdapter BuildOS();

    public IMicrocontrollerAdapter BuildPort();

    public Microcontroller GetResult();
}