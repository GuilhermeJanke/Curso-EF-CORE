import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any[] = [];;
    
  constructor(private http: HttpClient){}
  
  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void {
    const observable: Observable<any> = this.http.get('https://localhost:5001/api/Evento/');
    
    const observer = {
      next: (response: any) => {
        this.eventos = response;
      },
      error: (error: any) => {
        console.log(error);
      }
    };
    
    const subscription = observable.subscribe(observer);
  }
}
