import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { ScriptModel } from 'src/app/models/ScriptModel';
import { ScriptService } from 'src/app/services/script/script.service';

@Component({
  selector: 'app-create-edit-script',
  templateUrl: './create-edit-script.component.html',
  styleUrls: ['./create-edit-script.component.css']
})
export class CreateEditScriptComponent {

  script$:Observable<ScriptModel>;

  constructor( private route: ActivatedRoute,private scriptService:ScriptService) { }

  ngOnInit(): void {
    this.script$=this.scriptService.getById(Number(this.route.snapshot.paramMap.get('id')));
  }
}
