export interface ScriptModel {
  id: number;
  name: string;
  description: string;
  questions: Question[];

}

export interface Question {
  id: number;
  number: string;
  text: string;
  title:string;
  answers?: Answer[];
  type: QuestionType;
}

export interface Answer{
  id: number;
  text: string;
  jumpToQuestion?:string ;

}

 enum QuestionType {
  Input,
  Text,
  Form
}
