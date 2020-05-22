import {Component, Inject, Input, OnInit} from "@angular/core";
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-post-component',
  templateUrl: './post.component.html'
})

export class PostComponent{
  @Input() post;
  http:HttpClient;
  baseUrl:string;
  constructor(http:HttpClient,@Inject('BASE_URL') baseUrl:string) {
    this.http = http;
    this.baseUrl = baseUrl;

  }

  public UpVote(){

    console.log(this.post);
    this.http.put(this.baseUrl + 'api/post/Upvote',this.post).subscribe(res=>{this.post.rating++;},error => {console.error(error)});
  }
  public DownVote(){

    this.http.put(this.baseUrl + 'api/post/downvote',this.post).subscribe(res=>{this.post.rating--;},error => {console.error(error)});
  }
}
