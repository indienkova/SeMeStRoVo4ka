import {User} from "./User";

export interface Message {
  id:number;
  owner:User;
  text:string;
  ownerName:string;
  date:string;
  isMy:boolean;
}
