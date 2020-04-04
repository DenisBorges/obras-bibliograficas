import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AutorService } from '../services/autor.service';

@Component({
  selector: 'app-autor-add',
  templateUrl: './autor-add.component.html',
  styleUrls: ['./autor-add.component.css']
})
export class AutorAddComponent implements OnInit {


  angForm: FormGroup;
  constructor(private router: Router,private fb: FormBuilder, private ap: AutorService) {
    this.createForm();
  }

  createForm() {
    this.angForm = this.fb.group({
      nome: ['', Validators.required],
      nomedoMeio: [''],
      sobrenome: ['', Validators.required]

    });
  }

  addAutor(nome, nomedoMeio, sobrenome) {
    this.ap.addAutor(nome, nomedoMeio, sobrenome)
      .subscribe(res => {
        alert("Cadastrado com sucesso");
        this.router.navigate(['/']);
      },
      (err) => {
        debugger;
        alert(err);
      }
      );
  }


  ngOnInit() {
  }

}
