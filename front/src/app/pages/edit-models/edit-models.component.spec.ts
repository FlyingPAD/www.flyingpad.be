import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditModelsComponent } from './edit-models.component';

describe('EditModelsComponent', () => {
  let component: EditModelsComponent;
  let fixture: ComponentFixture<EditModelsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditModelsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditModelsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
