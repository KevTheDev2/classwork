package com.gamblerapi.controller;

import com.gamblerapi.dao.Casino.CasinoMemoryDao;
import com.gamblerapi.model.Casino;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class CasinoController {
    CasinoMemoryDao casinoDataSource;

    public CasinoController(CasinoMemoryDao casinoDataSource) {
        this.casinoDataSource =  new CasinoMemoryDao();
    }
    @GetMapping("/casinos")
        public List<Casino> getCasinos() {

        return casinoDataSource.getTheCasinos();
    }
}
