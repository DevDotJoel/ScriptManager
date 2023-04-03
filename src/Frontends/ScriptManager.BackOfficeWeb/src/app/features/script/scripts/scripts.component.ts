import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { ScriptModel } from 'src/app/models/ScriptModel';
import { ScriptService } from 'src/app/services/script/script.service';

@Component({
  selector: 'app-scripts',
  templateUrl: './scripts.component.html',
  styleUrls: ['./scripts.component.css']
})
export class ScriptsComponent {
  searchFilter:string;
  scripts$:Observable<ScriptModel[]>;

  constructor(private scriptService:ScriptService) { }

  ngOnInit(): void {
    this.scripts$ = this.scriptService.getAll();
  }

}
