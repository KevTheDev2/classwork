package com.gamblerapi.dao.Casino;

import com.gamblerapi.model.Casino;

import java.util.ArrayList;
import java.util.List;

public class CasinoMemoryDao {
    List<Casino> theCasinos;

    public CasinoMemoryDao() {
        this.theCasinos = new ArrayList<Casino>();
    }
}
