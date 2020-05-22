import {Component, Inject} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import {Message} from "../Interfaces/Message";

@Component({
  selector: 'app-chat-component',
  templateUrl: './chat.component.html'
})
export class Class {
  message:string;
  messages:Message[];

  constructor(http:HttpClient,@Inject('BASE_URL') baseUrl:string) {
    console.log(baseUrl);
    http.get<Message[]>(baseUrl + 'api/comment').subscribe(res=>{
      this.messages = res;
    },error => {console.error(error)});
  }
  public Send(){

  }
}
