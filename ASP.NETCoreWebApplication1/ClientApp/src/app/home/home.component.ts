import {Component, Inject, OnInit} from '@angular/core';
import {Post} from "../Interfaces/post";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent{
  public posts:Post[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Post[]>(baseUrl +  'api/post').subscribe(res=>{
    this.posts = res;
    },error => {console.error(error)});
  }

}
