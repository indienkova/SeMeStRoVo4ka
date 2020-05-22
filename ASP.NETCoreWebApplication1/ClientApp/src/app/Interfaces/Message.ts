import {User} from "./User";

export interface Message {
  id:number;
  owner:User;
  text:string;
}
