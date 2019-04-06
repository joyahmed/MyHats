import { Component, OnInit } from '@angular/core';

import { Hat } from '../hat';
import { HatsService } from '../hats.service';

@Component({
  selector: 'app-hat',
  templateUrl: './hat.component.html',
  styleUrls: ['./hat.component.css']
})
export class HatComponent implements OnInit {

  public Hats: Hat[];

  constructor(private hatsService: HatsService) { }

  ngOnInit() {

    this.hatsService.getHats()
      .subscribe(hats => {
        this.Hats = hats;
      });

  }

}
