import { Post } from "./post";

export interface User {
  firstName:string;
  lastName:string;
  birthDate:Date;
  rating:number;
  posts:Post[];

}
