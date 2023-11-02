public class Piano implements Instrument,KeyboardInstrument{

    @Override
    public void play() {
        // TODO Auto-generated method stub
       // throw new UnsupportedOperationException("Unimplemented method 'play'");
       System.out.println("Playing the Piano...");
    }

    @Override
    public void press() {
        // TODO Auto-generated method stub
        System.out.println("The key has been pressed.");
    
}
}