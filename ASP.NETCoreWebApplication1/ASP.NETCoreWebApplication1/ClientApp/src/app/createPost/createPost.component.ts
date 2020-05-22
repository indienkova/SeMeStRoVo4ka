import {Component, Inject} from "@angular/core";
import { HttpClient } from "@angular/common/http";
import {post} from "../Interfaces/post";
import {User} from "../Interfaces/User";

@Component({
  selector: 'app-createPost',
  templateUrl: './createPost.component.html'
})
export class CreatePostComponent {
  http:HttpClient;
  baseUrl:string;
  text:string;
  title:string;
  constructor(http:HttpClient,@Inject('BASE_URL') baseUrl:string) {
    this.http=http;
    this.baseUrl = baseUrl;
    this.text = '';
    this.title='';
  }
  public Send(){
    let owner:User = {birthDate:null,firstName:'Name',lastName:'lastName',rating:0}
    let post:post = {owner:owner,timeStamp:Date.now().toString(),rating:0,title:this.title,body:this.text}
    this.http.post(this.baseUrl + 'api/post/create',post).subscribe(res=>{},error => {console.error(error)});
  }
}
