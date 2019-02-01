import { Component, OnInit}                   from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

export interface Section {
  name: string;
  address: string;
}

@Component({
  selector:       'app-root',
  templateUrl:    './app.component.html',
  styleUrls:      ['./app.component.less']
})


export class AppComponent implements OnInit {
  title = 'CarRetailNetwork';
  now: number;

  dealers: Section[]  = [ { name: "Dream Cars",     address: "somewhere" }
                        , { name: "Super Cars",     address: "Somewhere else" }
                        , { name: "Bargain Cars",   address: " via Cavour" }];

  isLinear = false;
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;

  constructor(private _formBuilder: FormBuilder) {
    setInterval(() => { this.now = Date.now(); }, 500);
  }

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
  }
}
