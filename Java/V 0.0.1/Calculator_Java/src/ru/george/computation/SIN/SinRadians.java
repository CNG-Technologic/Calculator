package ru.george.computation.SIN;

import ru.george.start.MainStart;

public class SinRadians {
    MainStart startMain = new MainStart();
    public void sinRadians(Double DegreesInRadians) {
        double sinForRadians = Math.sin(DegreesInRadians);
        System.out.println(sinForRadians);
        startMain.startM();
    }
}
