import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AutorService } from '../services/autor.service';
import Autor from '../model/autor';

@Component({
  selector: 'app-autor-list',
  templateUrl: './autor-list.component.html',
  styleUrls: ['./autor-list.component.css']
})
export class AutorListComponent implements OnInit {


  autorList: Autor[];

  constructor(private ap: AutorService,
    private route: ActivatedRoute,
    private router: Router) {
  }

  ngOnInit() {
    this.getListAutor();
  }

  getListAutor() {

    this.ap.getListAutors().subscribe((res: Autor[]) => {
      this.autorList = res;
    });

  }

  deleteAutor(item:Autor) {

    const res = confirm('Gostaria de Excluir esse registro ?');
    if (res) {
      this.ap.deleteAutor(item.id).subscribe(() => {
        alert('Excluído com sucesso');
        item.visible = false;
      });
    }

  };

}
