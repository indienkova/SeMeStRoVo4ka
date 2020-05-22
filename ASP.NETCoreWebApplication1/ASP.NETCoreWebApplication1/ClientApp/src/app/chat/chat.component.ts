import {Component, Inject} from "@angular/core";
import {HttpClient} from "@angular/common/http";
import { Message } from "../Interfaces/Message";
import { User } from "../Interfaces/User";

@Component({
  selector: 'app-chat-component',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.css']
})

export class Chat {
  message:string = '';
  messages:Message[];
  http:HttpClient;
  baseUrl:string;

  constructor(http:HttpClient,@Inject('BASE_URL') baseUrl:string) {
    console.log(baseUrl);
    this.http = http;
    this.baseUrl = baseUrl;
    http.get<Message[]>(baseUrl + 'api/chat').subscribe(res=>{
      this.messages = res;
    },error => {console.error(error)});
  }
  public Send(){
    console.log(this.message);
    let owner:User = {firstName:'',lastName:'',rating:0,birthDate:null}
    let m:Message = {text:this.message,id:1,owner:owner,ownerName:'',date:"".toString(),isMy:true};
    this.http.post(this.baseUrl + 'api/chat/send', m).subscribe(res=>{this.messages.push(m)},error => {console.error(error)});

    this.http.get<Message[]>(this.baseUrl + 'api/chat').subscribe(res=>{
      this.messages = res;
      console.log(this.messages);
    },error => {console.error(error)});
  }
}
