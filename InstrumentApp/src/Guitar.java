public class Guitar implements Instrument, ElectronicInstrument{

    @Override
    public void play() {
        // TODO Auto-generated method stub
        //throw new UnsupportedOperationException("Unimplemented method 'play'");
        System.out.println("Playing the guitar..");}
    @Override
    public void tune() {
        // TODO Auto-generated method stub
        // throw new UnsupportedOperationException("Unimplemented method 'tune'");
        System.out.println("Guitar is being tuned");
    }
    public void setChord()
    {
        System.out.println("The Guitar has been tuned");
    }

}