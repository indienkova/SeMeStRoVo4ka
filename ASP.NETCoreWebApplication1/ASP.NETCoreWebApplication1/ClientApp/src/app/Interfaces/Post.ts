import { User } from "./User";

export interface Post {
  title:string;
  body:string;
  rating:number;
  timeStamp:string;
  owner:User;
}
