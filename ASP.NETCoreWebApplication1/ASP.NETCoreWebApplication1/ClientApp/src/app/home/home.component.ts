import {Component, Inject, OnInit} from '@angular/core';
import {post} from "../Interfaces/post";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent{
  public posts:post[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<post[]>(baseUrl +  'api/post').subscribe(res=>{
    this.posts = res;
    },error => {console.error(error)});
  }

}
