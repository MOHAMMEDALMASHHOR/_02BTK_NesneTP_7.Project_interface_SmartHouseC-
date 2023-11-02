public class Orchestra {
    private Instrument[]  instruments;

    public Orchestra() {
        this.instruments = new Instrument[]{new Guitar(),new Piano()};
    }
    public void PlayAll(){
        for (Instrument instrument : instruments) {
            instrument.play();
        }
    }


}
